
var slider = new Slider('#ex2', {});
///////////////////////////////////////////////

var vmin = document.getElementById("vminimo");
var outputmin = document.getElementById("valormin");
outputmin.innerHTML = vmin.value;

vmin.oninput = function () {
    outputmin.innerHTML = this.value;
}

/////////////////////////////////////////////

var vmax = document.getElementById("vmaximo");
var outputmax = document.getElementById("valormax");
outputmax.innerHTML = vmax.value;

vmax.oninput = function () {
    outputmax.innerHTML = this.value;
} 
