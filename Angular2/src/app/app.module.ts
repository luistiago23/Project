import { AppRoutingModule } from './app-routing/app-routing.module';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';

import { RegisterComponent } from './register/register.component';
import { RegisterService } from './register/register.service';

import { HttpModule } from '@angular/http';
import { FormsModule,ReactiveFormsModule } from '@angular/forms';

import { AuthGuard } from './guards/auth-guard';
import { AppModuleRegister } from './register/register.module';
import { NavComponent } from './nav/nav.component';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import { ListComponent } from './list/list-component';
import { ListService } from './list/list.service';
import {SelectButtonModule} from 'primeng/primeng';
import {MessagesModule} from 'primeng/primeng';
import {MessageModule} from 'primeng/primeng';
import {GrowlModule} from 'primeng/primeng';
import {MessageService} from 'primeng/components/common/messageservice';

@NgModule({
  declarations: [
    AppComponent,
    NavComponent,
    ListComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpModule,
    FormsModule,
    AppModuleRegister,
    BrowserAnimationsModule,
    ReactiveFormsModule,
    MessagesModule,
    MessageModule,
    GrowlModule
  ],
  providers: [RegisterService, AuthGuard, ListService, MessageService],
  bootstrap: [AppComponent]
})
export class AppModule { }
