import { Component, OnInit } from '@angular/core';
import { Product } from '../../models/product';
import { CurrencyPipe, NgClass, NgFor } from '@angular/common';
import { CoolProductsService } from '../../services/cool-products';
import { inject } from '@angular/core';

@Component({
  selector: 'app-product-list',
  imports: [NgFor,CurrencyPipe, NgClass],
  templateUrl: './product-list.component.html',
  styleUrl: './product-list.component.css'
})
export class ProductListComponent implements OnInit {

products: Product[] = [];
errMsg:string='';
coolProductService = inject(CoolProductsService); //DI

ngOnInit()
{
  //debugger;
  // Initialize the product list by fetching cool products
  this.coolProductService.getCoolProducts().subscribe({
    next: (data) => {
      this.products = data;
      //console.log('Product list initialized in ngOnInit:', this.products);
    },
    error: (err) => {
      //console.error('Error fetching cool products:', err);
      this.errMsg = 'Error fetching cool products: ' + err.message;
    }
  });
}

// constructor() {
//   // Initialize the product list by fetching cool products
//   this.products = this.coolProductService.getCoolProducts();
//   console.log('Product list initialized in the ctor:', this.products);
// }


}
