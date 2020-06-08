import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-presence',
  templateUrl: './presence.component.html',
  styleUrls: ['./presence.component.scss']
})
export class PresenceComponent implements OnInit {
  headers:string[]=["Student Name","Presence"];
  rows:object[]=[{familyName:"hale",firstName:"efrat",presence:true},{familyName:"hale",firstName:"talya",presence:false}];

  constructor() { }

  ngOnInit(): void {
  }

}
