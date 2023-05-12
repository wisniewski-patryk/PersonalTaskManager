import { Component, OnInit } from '@angular/core';
import { Task } from '../../models/task'

@Component({
  selector: 'app-tasks',
  templateUrl: './tasks.component.html',
  styleUrls: ['./tasks.component.css']
})
export class TasksComponent implements OnInit {

  task: Task = {
    id: 'zadanko',
    description: 'asdasd',
  };

  constructor() { }

  ngOnInit(): void {
  }

}
