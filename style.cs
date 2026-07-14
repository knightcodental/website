/* ========= RESET ========= */

*{
margin:0;
padding:0;
box-sizing:border-box;
scroll-behavior:smooth;
}

body{
font-family:'Poppins',sans-serif;
background:#f5f7fb;
color:#222;
overflow-x:hidden;
}

.container{
width:90%;
max-width:1400px;
margin:auto;
}

/* ========= HEADER ========= */

header{
position:fixed;
top:0;
left:0;
width:100%;
background:#ffffff;
box-shadow:0 5px 20px rgba(0,0,0,.08);
z-index:9999;
}

header .container{
display:flex;
justify-content:space-between;
align-items:center;
padding:18px 0;
}

.logo img{
width:140px;
height:auto;
display:block;
}

nav ul{
display:flex;
list-style:none;
gap:30px;
}

nav ul li a{
text-decoration:none;
font-size:16px;
font-weight:600;
color:#222;
transition:.3s;
}

nav ul li a:hover{
color:#0066cc;
}

.quote-btn{
background:#0066cc;
color:#fff;
padding:12px 24px;
border-radius:30px;
text-decoration:none;
font-weight:600;
transition:.3s;
}

.quote-btn:hover{
background:#004999;
}

/* ========= HERO ========= */

.hero{
height:100vh;
background:url("banner1.jpg") center/cover;
display:flex;
align-items:center;
justify-content:center;
text-align:center;
position:relative;
}

.overlay{
position:absolute;
top:0;
left:0;
width:100%;
height:100%;
background:rgba(0,0,0,.55);
}

.hero-content{
position:relative;
z-index:2;
color:#fff;
width:90%;
max-width:900px;
}

.hero h1{
font-size:58px;
font-weight:700;
margin-bottom:20px;
}

.hero h2{
font-size:28px;
font-weight:500;
margin-bottom:20px;
}

.hero p{
font-size:18px;
line-height:1.8;
margin-bottom:30px;
}

.hero-buttons{
display:flex;
justify-content:center;
gap:20px;
flex-wrap:wrap;
}

.btn,
.btn2{
padding:14px 35px;
border-radius:35px;
text-decoration:none;
font-weight:600;
transition:.3s;
}

.btn{
background:#0066cc;
color:#fff;
}

.btn2{
background:#25D366;
color:#fff;
}

.btn:hover{
background:#004999;
}

.btn2:hover{
background:#128C7E;
}
/* ===== STATS ===== */

.stats{
display:grid;
grid-template-columns:repeat(4,1fr);
gap:25px;
padding:70px 8%;
background:#fff;
text-align:center;
}

.stat{
padding:30px;
border-radius:15px;
box-shadow:0 8px 25px rgba(0,0,0,.08);
background:#fff;
transition:.3s;
}

.stat:hover{
transform:translateY(-8px);
}

.stat h2{
font-size:38px;
color:#0066cc;
margin-bottom:10px;
}

.stat p{
font-size:17px;
}

/* ===== SECTION ===== */

section{
padding:90px 8%;
}

.section-title{
text-align:center;
font-size:40px;
margin-bottom:50px;
color:#003366;
}

/* ===== CATEGORY ===== */

.category-grid{
display:grid;
grid-template-columns:repeat(auto-fit,minmax(250px,1fr));
gap:30px;
}

.category-card{
background:#fff;
padding:35px;
border-radius:18px;
text-align:center;
box-shadow:0 10px 25px rgba(0,0,0,.08);
transition:.35s;
}

.category-card:hover{
transform:translateY(-10px);
}

.category-card i{
font-size:50px;
color:#0066cc;
margin-bottom:20px;
}

.category-card h3{
margin-bottom:15px;
font-size:24px;
}

/* ===== PRODUCT GALLERY ===== */

.gallery-grid{
display:grid;
grid-template-columns:repeat(auto-fit,minmax(300px,1fr));
gap:30px;
}

.gallery-item{
background:#fff;
border-radius:20px;
overflow:hidden;
box-shadow:0 10px 25px rgba(0,0,0,.10);
transition:.35s;
}

.gallery-item:hover{
transform:translateY(-8px);
box-shadow:0 18px 35px rgba(0,0,0,.15);
}

.gallery-item img{
width:100%;
height:280px;
object-fit:cover;
transition:.4s;
}

.gallery-item:hover img{
transform:scale(1.08);
}

.gallery-item h3{
font-size:24px;
padding:18px 18px 8px;
}

.gallery-item p{
padding:0 18px 18px;
color:#666;
}

.product-btn{
display:inline-block;
margin:0 18px 20px;
padding:12px 24px;
background:#0066cc;
color:#fff;
text-decoration:none;
border-radius:30px;
font-weight:600;
transition:.3s;
}

.product-btn:hover{
background:#004999;
}

/* ===== CONTACT ===== */

.contact{
background:#003366;
color:#fff;
text-align:center;
}

.contact h2{
margin-bottom:25px;
font-size:40px;
}

.contact p{
margin:12px 0;
font-size:18px;
}

/* ===== FOOTER ===== */

footer{
background:#001b33;
color:#fff;
text-align:center;
padding:30px;
}

/* ===== FLOATING WHATSAPP ===== */

.floating-whatsapp{
position:fixed;
bottom:25px;
right:25px;
width:65px;
height:65px;
z-index:9999;
}

.floating-whatsapp img{
width:100%;
}

/* ===== MOBILE ===== */

@media(max-width:768px){

header .container{
flex-direction:column;
gap:15px;
}

.logo img{
width:110px;
}

nav ul{
flex-wrap:wrap;
justify-content:center;
gap:15px;
}

.hero h1{
font-size:34px;
}

.hero h2{
font-size:20px;
}

.hero{
height:80vh;
}

.stats{
grid-template-columns:1fr 1fr;
}

.section-title{
font-size:30px;
}

.gallery-grid{
grid-template-columns:1fr;
}

}
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
