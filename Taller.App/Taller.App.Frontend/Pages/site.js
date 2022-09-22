function captura (){
    var capturas = document.getElementsById("seleccion").value;
    alert(capturas);
    var idprovincia = document.getElementById("seleccion");
    var pro = idprovincia.options[idprovincia.selectedIndex].value;
    alert(idprovincia);
    alert(pro);
}

