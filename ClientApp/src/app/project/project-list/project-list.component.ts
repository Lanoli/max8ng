import { Component, OnInit } from '@angular/core';
import { ProjectsService } from '../Projects.service';
import { IProject } from '../IProject';

@Component({
  selector: 'app-project-list',
  templateUrl: './project-list.component.html',
  styleUrls: ['./project-list.component.css']
})
export class ProjectListComponent implements OnInit {

  constructor(private projectService: ProjectsService) { }

  private projects: IProject[];

  ngOnInit() {

    this.projectService.getProjects().subscribe(result => {
        console.log(result);
        this.projects = result;
      });

  }

}
