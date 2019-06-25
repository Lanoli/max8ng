import { Injectable } from '@angular/core';
import { IProject } from './IProject';
import { Observable, of } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { catchError, map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class ProjectsService {

  private projectUrl = 'http://www.max8.be/api/Project.asp';

  constructor(private http: HttpClient ) {}

  getProjects(): Observable<IProject[]> {

    console.log('Retrieving projects');
    return this.http.get<IProject[]>(this.projectUrl)
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
