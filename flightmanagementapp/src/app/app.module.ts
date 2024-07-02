import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { VolListComponent } from './components/vol-list/vol-list.component';
import { PiloteListComponent } from './components/pilote-list/pilote-list.component';
import { AvionListComponent } from './components/avion-list/avion-list.component';
import { AddVolComponent } from './components/add-vol/add-vol.component';
import { MainLayoutComponent } from './layouts/main-layout/main-layout.component';
import { AuthLayoutComponent } from './layouts/auth-layout/auth-layout.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { HttpClientModule } from '@angular/common/http';
import { AvionService } from './services/avion.service';
import { PiloteService } from './services/pilote.service';
import { VolService } from './services/vol.service';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';




@NgModule({
  declarations: [
    AppComponent,
    VolListComponent,
    PiloteListComponent,
    AvionListComponent,
    AddVolComponent,
    MainLayoutComponent,
    AuthLayoutComponent
    
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    NgbModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [
    AvionService,
    PiloteService,
    VolService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
