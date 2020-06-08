import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-mark',
  templateUrl: './mark.component.html',
  styleUrls: ['./mark.component.scss']
})
export class MarkComponent implements OnInit {
arr:object[]=[{familyName:"hale",firstName:"efrat",mark:100,subject:"english"},{familyName:"talya",name:"hale",mark:100,subject:"hebrew"}];
  constructor() { }

  ngOnInit(): void {
  }

}
