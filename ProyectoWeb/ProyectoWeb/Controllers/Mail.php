<?php 

$mail='efrojasm@gmail.com'; 

  
$nombre = $_POST['nombre']; 
$email = $_POST['email']; 
$msg = $_POST['mensaje']; 

$thank="index.cshtml"; 

$message = " 
nombre:".$nombre." 
email:".$email." 
msg:".$msg.""; 
   
  if (mail($mail,"consulta",$message))  
       Header ("Location: $thank"); 
   
 ?>
