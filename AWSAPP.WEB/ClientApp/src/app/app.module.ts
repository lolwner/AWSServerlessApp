import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AcquaintanceService } from './core/services/acquaintance.service';
import { AppComponent } from './app.component';
import { AcquaintanceGridComponent } from './acquaintance-grid/acquaintance-grid.component';
import { HttpClientModule } from '@angular/common/http';

@NgModule({
  declarations: [
    AppComponent,
    AcquaintanceGridComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule
  ],
  providers: [AcquaintanceService],
  bootstrap: [AppComponent]
})
export class AppModule { }
