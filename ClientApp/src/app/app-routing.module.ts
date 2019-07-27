import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { BracketDisplayComponent } from './bracket-display/bracket-display.component';

const routes: Routes = [
  {
    path: 'bracket',
    component: BracketDisplayComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
