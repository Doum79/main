import { Component, Input, OnDestroy, OnInit } from '@angular/core';
import { Subject, takeUntil } from 'rxjs';
import { Pilote } from 'src/app/models/pilote.model';

import { PiloteService } from 'src/app/services/pilote.service';

@Component({
  selector: 'app-pilote-list',
  templateUrl: './pilote-list.component.html',
  styleUrls: ['./pilote-list.component.css']
})
export class PiloteListComponent implements OnInit, OnDestroy{

  public pilotes: Pilote[]=[];
  private readonly destroy$ = new Subject<void>();
  constructor(private readonly piloteServices: PiloteService) {}

  ngOnInit(): void {
    this.getAllPilotesObservable();
  }
  public ngOnDestroy(): void {
    this.destroy$.next();
    this.destroy$.complete();
  }

  private getAllPilotesObservable(): void {
    this.piloteServices
      .getAllPilot()
      .pipe(takeUntil(this.destroy$))
      .subscribe((pilotes) => {
        this.pilotes = pilotes;
      });
  }
}
