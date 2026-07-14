// ===== Hero Slider =====

const slides = document.querySelectorAll(".slide");
let currentSlide = 0;

function showSlide(index){

slides.forEach(slide=>{
slide.classList.remove("active");
});

slides[index].classList.add("active");

}

if(slides.length>0){

showSlide(currentSlide);

setInterval(()=>{

currentSlide++;

if(currentSlide>=slides.length){

currentSlide=0;

}

showSlide(currentSlide);

},5000);

}

// ===== Sticky Header =====

window.addEventListener("scroll",()=>{

const header=document.querySelector("header");

if(window.scrollY>50){

header.style.boxShadow="0 10px 25px rgba(0,0,0,.15)";

}else{

header.style.boxShadow="0 5px 20px rgba(0,0,0,.08)";

}

});

// ===== Smooth Scroll =====

document.querySelectorAll('a[href^="#"]').forEach(anchor=>{

anchor.addEventListener("click",function(e){

e.preventDefault();

document.querySelector(this.getAttribute("href")).scrollIntoView({

behavior:"smooth"

});

});

});

// ===== Product Animation =====

const cards=document.querySelectorAll(".gallery-item");

cards.forEach(card=>{

card.addEventListener("mouseenter",()=>{

card.style.transform="translateY(-10px)";

});

card.addEventListener("mouseleave",()=>{

card.style.transform="translateY(0)";

});

});