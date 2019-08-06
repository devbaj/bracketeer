import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpService } from './http.service';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BracketDisplayComponent } from './bracket-display/bracket-display.component';
import { ContestCreationComponent } from './contest-creation/contest-creation.component';
import { LoginRegisterComponent } from './login-register/login-register.component';
import { importType } from '@angular/compiler/src/output/output_ast';
import { UserService } from './user.service';

@NgModule({
  declarations: [
    AppComponent,
    BracketDisplayComponent,
    ContestCreationComponent,
    LoginRegisterComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [
    HttpService,
    UserService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
