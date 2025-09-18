// import { Injectable } from '@angular/core';

// @Injectable({
//   providedIn: 'root'
// })
// export class Data {
  
// }

import { Injectable } from '@angular/core';

export interface Food {

  name: string;

  price: number;

}

export interface Restaurant {

  name: string;

  foods: Food[];

}

export const RESTAURANTS: Restaurant[] = [

  {

    name: 'Pizza Palace',

    foods: [

      { name: 'Margherita', price: 250 },

      { name: 'Pepperoni', price: 300 }

    ]

  },

  {

    name: 'Burger House',

    foods: [

      { name: 'Classic Burger', price: 150 },

      { name: 'Cheese Burger', price: 180 }

    ]

  }

];

@Injectable({

  providedIn: 'root'

})

export class Data {

  getRestaurants(): Restaurant[] {

    return RESTAURANTS;

  }

}
