import { Component } from '@angular/core';
import {Bicycle} from "src/app/models/bicycle.model"
import { BicycleService } from 'src/app/services/bicycle.service';

@Component({
  selector: 'app-order-bicycle',
  templateUrl: './order-bicycle.component.html',
  styleUrls: ['./order-bicycle.component.css']
})
export class OrderBicycleComponent {
  bicycle: Bicycle = {
    name: '',
    email: '',
    description: ''
  };
  submitted = false;

  constructor(private bicycleService: BicycleService) {}

  ngOnInit(): void {

  }

  saveOrder(): void {
    const data={
      name: this.bicycle.name,
      email: this.bicycle.email,
      description: this.bicycle.description
    };

    console.log(data)

    this.bicycleService.create(data).subscribe({
      next: (res) => {
        console.log(res);
        this.submitted = true;
      },
      error: (e) => console.log(e)
    })
  }
}
