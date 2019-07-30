import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpService } from './http.service';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BracketDisplayComponent } from './bracket-display/bracket-display.component';
import { ContestCreationComponent } from './contest-creation/contest-creation.component';

@NgModule({
  declarations: [
    AppComponent,
    BracketDisplayComponent,
    ContestCreationComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [
    HttpService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
