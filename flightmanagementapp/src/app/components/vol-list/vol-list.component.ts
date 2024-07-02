import { Component, Input, OnInit, ViewChild } from '@angular/core';
import { Vol } from 'src/app/models/vol.model';
import { VolService } from 'src/app/services/vol.service';

@Component({
  selector: 'app-vol-list',
  templateUrl: './vol-list.component.html',
  styleUrls: ['./vol-list.component.css']
})
export class VolListComponent  implements OnInit{

  flights: Vol[] = [];
  filteredFlights: Vol[] = [];
  filterTerm: string ='';

  constructor(private volServices: VolService) {
    
  }

  ngOnInit(): void {
   
   this.loadVols();
  }

  loadVols(): void {
    this.volServices.getAllFlights().subscribe((flights: Vol[]) => {
      this.flights = flights;
      this.filteredFlights = flights;
       });

  }
  addFlightToList(newFlight: Vol): void {
    this.volServices.addFlight(newFlight).subscribe((flight: Vol) => {
      this.flights.push(flight);
    });
  }

  applyFilter(filterValue: string): void{
  
    this.filterTerm = filterValue;
      this.filteredFlights  = this.flights.filter(flight =>{
        const numvol = flight.numvol ? flight.numvol.toString() :""; 
       const numpilote= flight.numpilote ? flight.numpilote.toString() :''; 
      const numavion = flight.numavion ? flight.numavion.toString() : '';
      const villedep = flight.villedep ? flight.villedep.toString() : '';
        const villearr = flight.villearr ? flight.villearr.toString() : '';
        const heuredep = flight.heuredep ?flight.heuredep.toString() :'' ;
        const heurearr =flight.heurearr ? flight.heurearr.toString() : '';


        return flight.numvol.includes(this.filterTerm) ||
                numpilote.includes(this.filterTerm) ||
                numavion.includes(this.filterTerm) ||
                villedep.includes(this.filterTerm) ||
                villearr.includes(this.filterTerm) ||
                heuredep.includes(this.filterTerm) ||
                heurearr.includes(this.filterTerm);

  });
   
  }

}
