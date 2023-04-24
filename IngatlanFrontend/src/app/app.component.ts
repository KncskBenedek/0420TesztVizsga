import { Component } from '@angular/core';
import { Ingatlan, Kategoria } from './shared/interfaces';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  ingatlanok: Ingatlan[] =[{
    kategoria:"Ház",
    katId: 1,
    leiras: "a",
    hirdDatum: "2023-02-03",
    tehermentes: true,
    kepUrl: "https://upload.wikimedia.org/wikipedia/commons/e/e1/Google_Chrome_icon_%28February_2022%29.svg"
  },{
    kategoria:"Ház",
    katId: 1,
    leiras: "a",
    hirdDatum: "2023-02-03",
    tehermentes: true,
    kepUrl: "https://upload.wikimedia.org/wikipedia/commons/e/e1/Google_Chrome_icon_%28February_2022%29.svg"
  },{
    kategoria:"Ház",
    katId: 1,
    leiras: "a",
    hirdDatum: "2023-02-03",
    tehermentes: true,
    kepUrl: "https://upload.wikimedia.org/wikipedia/commons/e/e1/Google_Chrome_icon_%28February_2022%29.svg"
  },{
    kategoria:"Ház",
    katId: 1,
    leiras: "a",
    hirdDatum: "2023-02-03",
    tehermentes: true,
    kepUrl: "https://upload.wikimedia.org/wikipedia/commons/e/e1/Google_Chrome_icon_%28February_2022%29.svg"
  }]


  kategoriak: Kategoria[] = [
    {
      id:1,
      kategoria: "Ház"
    },{
      id:2,
      kategoria: "Garázs"
    },{
      id:3,
      kategoria: "farm"
    },{
      id:4,
      kategoria: "cica"
    }
  ];
}
