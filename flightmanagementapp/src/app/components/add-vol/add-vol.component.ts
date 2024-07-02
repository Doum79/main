import { Component, EventEmitter, Output } from '@angular/core';
import { Vol } from 'src/app/models/vol.model';


@Component({
  selector: 'app-add-vol',
  templateUrl: './add-vol.component.html',
  styleUrls: ['./add-vol.component.css']
})
export class AddVolComponent {
  
  @Output() flightAdded = new EventEmitter<Vol>();

  newFlight: Vol = {
    numvol:'',
    numpilote: 0,
    numavion: 0,
    villedep:'',
    villearr:'',
    heuredep:'',
    heurearr:''
  };

  addFlight(): void {
    this.flightAdded.emit(this.newFlight);
    this.newFlight = {
      numvol:'',
      numpilote: 0,
      numavion: 0,
      villedep:'',
      villearr:'',
      heuredep:'',
      heurearr:''
    };
  }

}
