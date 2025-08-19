import { Component, inject, OnInit } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { CoolProductsService } from '../../services/cool-products';
import { Product } from '../../models/product';

@Component({
  selector: 'app-product-add',
  imports: [FormsModule],
  templateUrl: './product-add.component.html',
  styleUrl: './product-add.component.css'
})
export class ProductAddComponent implements OnInit {

  newProduct:Product = {
    id: 0,
    name: '',
    price: 0,
    catagory: '',
    brand: '',
    country: '',
    instock: false,
    isDeleted: false

  };

  msg:string = '';

  coolProductsService = inject(CoolProductsService);

  constructor() { }

  ngOnInit(): void {
  }

  onSubmit(productForm:any) {
    console.log('Adding product:', productForm.value);
   this.coolProductsService.postCoolProduct(this.newProduct).subscribe({
     next: (product) => {
       console.log('Product added successfully:', product);
       this.msg = 'Product added successfully!';
        productForm.reset(); // Reset the form after successful submission
     },
     error: (error) => {
       console.error('Error adding product:', error);
       this.msg = 'Error adding product.';
     }
   });
  }
}
