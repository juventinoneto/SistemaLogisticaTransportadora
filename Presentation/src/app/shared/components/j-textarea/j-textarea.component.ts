import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'j-textarea',
  templateUrl: './j-textarea.component.html',
  styleUrls: ['./j-textarea.component.css']
})
export class JTextareaComponent implements OnInit {

  @Input() label: string = 'Label';

  constructor() { }

  ngOnInit() {
  }

}
