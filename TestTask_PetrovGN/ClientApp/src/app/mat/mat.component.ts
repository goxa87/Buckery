import {Component} from '@angular/core';
import {FormControl,ReactiveFormsModule} from '@angular/forms';

/**
 * @title Simple autocomplete
 */
@Component({
  selector: 'autocomplete-simple-example',
  templateUrl: 'mat.component.html',
  styleUrls: ['mat.component.css'],
})
export class MatExampleComponent {
  myControl = new FormControl();
  cars: Cars[] = [
    {index: '21065', viewValue: 'Шоха'},
    {index: '21075', viewValue: 'Семеха'},
    {index: '35545', viewValue: 'Нива'}
  ];
  selected: string = 'выбирайте';
}

class Cars{
    index:string;
    viewValue:string;
}