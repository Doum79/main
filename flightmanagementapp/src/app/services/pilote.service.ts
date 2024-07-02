import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';
import { Pilote } from '../models/pilote.model';
import { environment } from '../environments/environments';
import { HttpClient } from '@angular/common/http';


@Injectable()
export class PiloteService {
 
  private readonly routeBase = 'api/controller/Pilote';

  constructor(private readonly httpClient: HttpClient) {}

  public getAllPilot(): Observable<Pilote[]> {
    const url = `${environment.apiBaseUrl}/${this.routeBase}`;
    return this.httpClient.get<Pilote[]>(url);
  }
}
