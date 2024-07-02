import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { MainLayoutComponent } from './layouts/main-layout/main-layout.component';
import { PiloteListComponent } from './components/pilote-list/pilote-list.component';
import { AvionListComponent } from './components/avion-list/avion-list.component';
import { VolListComponent } from './components/vol-list/vol-list.component';

const routes: Routes = [
  {
    path: '',
    component: MainLayoutComponent,
    children: [
      {
        path: 'vol',
        component: VolListComponent,
      },
      {
        path: 'pilote',
        component: PiloteListComponent
      },
      {
        path: 'avion',
        component: AvionListComponent
      }
    ]
  },
  {
    path: '**',
    redirectTo: '',
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
