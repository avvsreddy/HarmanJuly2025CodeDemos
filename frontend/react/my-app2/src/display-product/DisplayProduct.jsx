function DisplayProduct( {product})
{
    //console.log('product',id)
    //const {id,name,price} = product;
       return (
        <>
      <ul>
        <li>{product.id}</li>
        <li>{product.name}</li>
        <li>{product.price}</li>
      </ul>  
    
        </>
       );
}
 
// DisplayProduct.defaultProps ={
//     id:1,
//     name:'new product',
//     price:100
// };
export default DisplayProduct;