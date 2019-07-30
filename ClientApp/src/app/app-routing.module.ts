import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { BracketDisplayComponent } from './bracket-display/bracket-display.component';
import { ContestCreationComponent } from './contest-creation/contest-creation.component';

const routes: Routes = [
  {
    path: 'bracket',
    component: BracketDisplayComponent
  },
  {
    path: 'contest',
    component: ContestCreationComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
