import { Injectable } from '@angular/core';
import { CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot } from '@angular/router';
import { Observable } from 'rxjs/Observable';
import { RegisterService } from '../register/register.service';
import { Router } from '@angular/router';

@Injectable()
export class AuthGuard implements CanActivate {

    constructor (private repository: RegisterService,
                 private routers: Router,
                ) { }

    canActivate (
        route: ActivatedRouteSnapshot,
        state: RouterStateSnapshot,

    ): Observable<boolean> | boolean {

        return this.verificarAcesso();
    }

    private verificarAcesso() {
        if (localStorage.getItem('currentUser')) {
          return true;
        }

        this.routers.navigate(['/register']);
        return false;
      }

}