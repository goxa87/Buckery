import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import {interval} from 'rxjs';

@Component({
  selector: 'bun',
  templateUrl: './buns.component.html'
})
export class BunComponent {
  buns: Bun[];
  baseUrl:string;
  http: HttpClient;

  constructor(http: HttpClient,
     @Inject('BASE_URL') baseUrl: string
     ) {
        this.baseUrl = baseUrl;
        this.http = http;
  }

  ngOnInit(){
      const secondsCounter = interval(3000);
      secondsCounter.subscribe(()=>this.getData());
  }

  getData(){
        this.http.get<Bun[]>(this.baseUrl + 'Bun/Get').subscribe( bans => {
        this.buns = bans;
    }, error => console.error(error))
  }



}

export interface Bun {
    name : string;
    creationDate: string;
    controlFreshPeriod: string;
    storageLife :string;
    isAlive : boolean;
    startPrice: number;
    curentPrice: number;
}