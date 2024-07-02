import { Component, OnDestroy, OnInit } from '@angular/core';
import { Subject, takeUntil } from 'rxjs';
import { Avion } from 'src/app/models/avion.model';
import { AvionService } from 'src/app/services/avion.service';


@Component({
  selector: 'app-avion-list',
  templateUrl: './avion-list.component.html',
  styleUrls: ['./avion-list.component.css']
})
export class AvionListComponent implements OnInit, OnDestroy {
  public avions: Avion[]=[];
  private readonly destroy$ = new Subject<void>();



  constructor(private readonly avionServices: AvionService) {}
  

  ngOnInit(): void {
    this.getAllAvionsObservable();
  }
  public ngOnDestroy(): void {
    this.destroy$.next();
    this.destroy$.complete();
  }

  private getAllAvionsObservable(): void {
    this.avionServices
      .getAllPlan()
      .pipe(takeUntil(this.destroy$))
      .subscribe((avions) => {
        this.avions = avions;
      });
  }
}
