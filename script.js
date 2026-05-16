document.querySelectorAll('.hero,.section,.contact,.card,.service').forEach(el=>el.classList.add('reveal'));
const obs=new IntersectionObserver(entries=>entries.forEach(e=>{if(e.isIntersecting)e.target.classList.add('show')}),{threshold:.12});
document.querySelectorAll('.reveal').forEach(el=>obs.observe(el));
