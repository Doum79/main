import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';
import { Vol } from '../models/vol.model';
import { environment } from '../environments/environments';

@Injectable()
export class VolService {

  private readonly routeBase = 'api/Vol/Vol';
  private readonly routeBases = 'api/Vol';

  constructor(private http: HttpClient) { }

  getAllFlights(): Observable<Vol[]> {
    const url = `${environment.apiBaseUrl}/${this.routeBase}`;
    return this.http.get<Vol[]>(url);
  }

  addFlight(vols: Vol): Observable<Vol> {
    const url = `${environment.apiBaseUrl}/${this.routeBases}`;
    return this.http.post<Vol>(url, vols);
  }
  
}
