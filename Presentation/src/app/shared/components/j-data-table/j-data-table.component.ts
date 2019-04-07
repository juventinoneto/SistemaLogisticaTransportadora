import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'j-data-table',
  templateUrl: './j-data-table.component.html',
  styleUrls: ['./j-data-table.component.css']
})
export class JDataTableComponent implements OnInit {

  @Input() values: any[] = [1, 2, 3, 4, 5];

  constructor() { }

  ngOnInit() {
  }

}
