import { Injectable } from '@angular/core';
import { Task } from '../models/task'
import { TASKS } from '../mocks/mock-tasks';
import { Observable, of } from 'rxjs';
import { MessageService } from './message.service';

@Injectable({
  providedIn: 'root'
})
export class TaskService {

  constructor(private messageService: MessageService) {}

  getTasks(): Observable<Task[]>{
    // TODO: connect to API
    const tasks = of(TASKS);
    this.messageService.add('TaskService: fetched tasks')
    return tasks;
  }

  getTask(id: string) : Observable<Task> {
    // TODO: connect to API
    const task = TASKS.find(t => t.id === id)!;
    return of(task);
    
  }
}
