import { Component, OnInit } from '@angular/core';
import { EmployeesApiService } from '../services/employees-api.service';
import { Employee } from '../models/employee';
import { MatSnackBar } from '@angular/material/snack-bar';

@Component({
  selector: 'app-employees',
  templateUrl: './employees.component.html',
  styleUrls: ['./employees.component.css']
})
export class EmployeesComponent implements OnInit {

  employeeId?: number;
  employees: Employee[] = [];
  displayedColumns: string[] = ['id', 'employee_name', 'employee_salary', 'employee_age', 'profile_image'];


  constructor (private apiService: EmployeesApiService, private snackBar: MatSnackBar) {  }

  ngOnInit(): void {
    this.getEmployees();
  }

  getEmployees(): void {
    this.apiService.getEmployees().subscribe({
      next: data => {
        this.employees = data;
      },
      error: error => {
        this.snackBar.open(error.message, 'Close', {
          duration: 3000,
        });
      }
    });
  }

  getEmployeeById(id: number): void {
    this.apiService.getEmployeeById(id).subscribe({
      next: data => {
        this.employees = [data];
      },
      error: error => {
        this.snackBar.open(error.message, 'Close', {
          duration: 3000,
        });
      }
    });
  }

  search(): void {
    if (this.employeeId && this.employeeId > 0) {
      console.log(`id:${this.employeeId}`);
      this.getEmployeeById(this.employeeId);
    } else {
      console.log('Not accepted');
      this.getEmployees();
    }
  }
}
