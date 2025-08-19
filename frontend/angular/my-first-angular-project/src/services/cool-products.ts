import { HttpClient } from "@angular/common/http";
import { Product } from "../models/product";
import { inject, Injectable } from "@angular/core";
import { urlBase } from "./urlbase";


@Injectable({
    providedIn: 'root'
})
export class CoolProductsService
{
    urlBase: string = urlBase;
    httpClient: HttpClient = inject(HttpClient);

    getCoolProducts()
    {
        return this.httpClient.get<Product[]>(`${this.urlBase}/api/CoolProducts`)
         
    }

    postCoolProduct(product: Product)
    {
        return this.httpClient.post<Product>(`${this.urlBase}/api/CoolProducts`, product)
    }
    deleteCoolProduct(productId: number)
    {
        return this.httpClient.delete(`${this.urlBase}/api/CoolProducts/${productId}`)
    }
    putCoolProduct(product: Product)
    {
        return this.httpClient.put<Product>(`${this.urlBase}/api/CoolProducts/${product.id}`, product)
    }
}