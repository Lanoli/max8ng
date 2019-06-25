import { Injectable } from '@angular/core';
import { IProject } from './IProject';
import { Observable, of } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { catchError, map, tap } from 'rxjs/operators';
import { environment } from '../../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class ProjectsService {

  private projectsResource = 'projects'

  constructor(private http: HttpClient ) {}


  getProjects(): Observable<IProject[]> {

    console.log('Retrieving projects');
    return this.http.get<IProject[]>(environment.apiBaseUrl + this.projectsResource)
    .pipe(tap(projects => console.log(projects)))
    .pipe(catchError(this.handleError<IProject[]>('getProjects', [])));
  }

  private handleError<T> (operation = 'operation', result?: T)
  {
    return(error: any): Observable<T> => {
      console.error(error);
      return of(result as T);
    }
  }
}
