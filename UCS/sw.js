self.addEventListener('install', function(e) {
 e.waitUntil(
   caches.open('video-store').then(function(cache) {
     return cache.addAll([
       'https://tomatoclock.000webhostapp.com/questionary/',
       'https://tomatoclock.000webhostapp.com/questionary/confirm.html',
	   'https://tomatoclock.000webhostapp.com/questionary/memory.html',
	   'https://tomatoclock.000webhostapp.com/questionary/others.html',
	   'https://tomatoclock.000webhostapp.com/questionary/show.html',
	   'https://tomatoclock.000webhostapp.com/questionary/page0.html',
	   'https://tomatoclock.000webhostapp.com/questionary/page1.html',
	   'https://tomatoclock.000webhostapp.com/questionary/page2.html',
       'https://tomatoclock.000webhostapp.com/questionary/index.js',
	   'https://tomatoclock.000webhostapp.com/questionary/jquery.js',
	   'https://tomatoclock.000webhostapp.com/questionary/jquery.cookie.js',
	   'https://tomatoclock.000webhostapp.com/questionary/func.js',
	   'https://tomatoclock.000webhostapp.com/questionary/style.css',
     ]);
   })
 );
});

self.addEventListener('fetch', function(e) {
  console.log(e.request.url);
  e.respondWith(
    caches.match(e.request).then(function(response) {
      return response || fetch(e.request);
    })
  );
});
