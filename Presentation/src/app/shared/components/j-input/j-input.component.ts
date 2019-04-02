import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'j-input',
  templateUrl: './j-input.component.html',
  styleUrls: ['./j-input.component.css']
})
export class JInputComponent implements OnInit {

  @Input() placeholder: string = 'Label';

  private _value: string = '';

  constructor() { }

  ngOnInit() {
  }

}
