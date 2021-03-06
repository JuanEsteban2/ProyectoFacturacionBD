<div align="center">
  <h1>Proyecto grandes mercados</h1>
</div>


## TABLA DE CONTENIDOS
- [Introducción](#-introducción-)
- [Herramientas usadas](#-herramientas-usadas-)
- [Necesidad del aplicativo](#necesidad-del-aplicativo)
- [Diseño de interfaz.](#-diseño-de-interfaz)
- [MER](#mer)
- [Arquitectura de Software](#arquitectura-de-software)
- [Uso de cada capa](#uso-de-cada-capa)
- [Capa de presentación](#capa-de-presentación)
- [Capa de aplicación](#capa-de-aplicación)
- [Capa de datos](#capa-de-datos)
- [Metodología](#metodología)

<h2> Introducción </h2>
<p> Los supermercados necesitan poder llevar un control sobre su stock de productos además de poder saber su capacidad de almacenaje. Sin mencionar que cada producto tiene que tener su propia denominación. Nuestro proyecto tiene el objetivo de a través de nuestra aplicación cumpla todas estas necesidades, para que el supermercado pueda evitar complicaciones o errores que terminen en perdidas para este, logrando además que sea mas eficiente en el tema de introducción de nuevos productos.</p>

<h2> Herramientas usadas </h2> 
<p>Para la aplicación de nuestro problema utilizaremos la base de datos de Microsoft SQL server y como utilizamos la base Microsoft utilizaremos un software para modelar y programar que sea compatible con este, este es visual estudio, el cual permite hacer una programación por capas para proteger la información y permite realizar la funcionalidad y el diseño por separado.</p> 

<h2>Necesidad del aplicativo</h2>
<p>La necesidad de este aplicativo se da por el objetivo de tener un orden de productos más eficaz y un registro de estos más sencillo y más rápido de este, haciendo que los nuevos productos, sea más eficiente buscarlos en la base de datos con solo tener el id de este o con solo un QR, ya que este tiene todos los datos que se tienen del producto como es el costo y la cantidad, por otro caso, también el aplicativo se encargar de ordenar todos los productos en tablas en donde estas tablas se muestra los datos de este producto facilitando, la manera de manejar el inventario.   
  <br>También la aplicación se encarga  que cualquier producto nuevo que se introduzca, no se pierda el registro de este, haciendo que tenga un comprobante de las ventas de este y su respectiva cantidad, por otro caso el aplicativo se encarga del eliminar productos en los cuales ya no se fabriquen o no se posea existencias de este en ninguna tienda, por esto cada producto que se introduce en la base de datos, a este se le crea un QR el cual este QR muestra la información del producto tanto el costo como en que tiendas se encuentran de este, con esto involucrando una facilidad en la creación de una factura para el cliente del que está comprando el producto en la caja. 
  
 <h2> Diseño de interfaz</h2>
 <p> la interfaz de usuario se realiza en Balsamiq  <a href=https://balsamiq.cloud/se2fzjj/punr5ot/r1D7A?f=N4IgUiBcAMA0IDkpxAYWfAMhkAhHAsjgFo4DSUA2gLoC%2BQA%3D>haz clik para mirar la interfaz</a></p>


 <h2>MER</h2>
 <br>
<div align="center"> 
  <img src=https://github.com/JuanEsteban2/ProyectoFacturacionBD/blob/main/WhatsApp%20Image%202022-05-01%20at%209.10.04%20PM.jpeg>
  
</div>
<br>

<h2>Arquitectura de Software</h2>
<p>La arquitectura que se va a utilizar en el proyecto es de 3 capas en la cual consiste en establecer en separar las aplicaciones en tres capas de informática, lógica y física: la capa de presentación o la interfaz de usuario, la capa de aplicación o donde se procesan los datos, y la capa de datos donde se almacenan y gestionan los datos asociados con la aplicación.
<h2>Uso de cada capa
<h3>Capa de presentación</h3>
La capa de presentación es la interfaz de usuario y de comunicación de la aplicación, donde el usuario final interactúa con la aplicación. Su objetivo principal es mostrar información al usuario y recopilar datos de este. 
<h3>Capa de aplicación</h3>
Capa de aplicación, también conocido como la capa lógica o media, es el núcleo de la aplicación. En esta capa es la encargada, de procesar la información recopilada en la capa de presentación, a veces con otra información en la capa de datos, mediante la lógica que se le dé a esta en el código, como un conjunto específico de reglas. La capa de aplicación también puede añadir, eliminar o modificar datos en la capa de datos.
<h3>Capa de datos</h3>
La capa de datos, a veces denominado como la base de datos, en esta capa es donde se almacena y gestiona la información procesada por la aplicación, que en este caso se dará uso de una base de datos relacional o SQL.  
  
  
<h2>Metodología</h2>
<p>Para del desarrollo de esta aplicación de escritorio se usará un modelo evolutivo para el proceso del software, específicamente el incremental. Esta metodología es particularmente útil en este proyecto, teniendo en cuenta que se trata de la primera experiencia formal del equipo en la creación de una aplicación, ya que se cuenta con una participación activa del cliente. Por otro lado, la metodología misma permite adaptar los resultados parciales que se tendrán a las sugerencias del cliente. 
  <br> En esta metodología las fases no se separan necesariamente, sino que según lo considere el equipo y los comentarios que se obtengan por parte del cliente, se pueden mezclar las distintas fases, así como avanzar y regresar en ellas. 
  <br> Para empezar, se tiene planeado desarrollar una versión inicial de lo que interpretamos como necesidades del cliente. Esto para posteriormente empezar a explorar aquellos aspectos que no han sido entendidos y finalmente entregar la forma definitiva del producto que ofrezca de manera satisfactoria todos los servicios que el cliente requiere.</p>
  
<br>
<div align="center"> 
  <img src=http://ingsoftware.weebly.com/uploads/2/3/8/2/23822483/6836777_orig.jpg>
  
</div>
<br>
