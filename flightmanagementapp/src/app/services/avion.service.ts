import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { BehaviorSubject, Observable } from 'rxjs';
import { Avion } from '../models/avion.model';
import { environment } from '../environments/environments';

@Injectable()
export class AvionService {
  private readonly routeBase = 'api/controller/Avion';

  constructor(private readonly httpClient: HttpClient) {}

  public getAllPlan(): Observable<Avion[]> {
    const url = `${environment.apiBaseUrl}/${this.routeBase}`;
    return this.httpClient.get<Avion[]>(url);
  }

}
