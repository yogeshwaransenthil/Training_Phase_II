import { Component } from '@angular/core';

@Component({
  selector: 'app-twowaybind',
  templateUrl: './twowaybind.component.html',
  styleUrls: ['./twowaybind.component.css']
})
export class TwowaybindComponent {

  username: string = '';

  resetUsername() {
    this.username = '';
  }

}
