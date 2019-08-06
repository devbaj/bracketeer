import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { BracketDisplayComponent } from './bracket-display/bracket-display.component';
import { ContestCreationComponent } from './contest-creation/contest-creation.component';
import { LoginRegisterComponent } from './login-register/login-register.component';

const routes: Routes = [
  {
    path: 'bracket',
    component: BracketDisplayComponent
  },
  {
    path: 'contest',
    component: ContestCreationComponent
  },
  {
    path: 'user',
    component: LoginRegisterComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
