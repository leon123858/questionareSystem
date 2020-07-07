self.addEventListener('install', function(e) {
 e.waitUntil(
   caches.open('video-store').then(function(cache) {
     return cache.addAll([
       '/',
       '/confirm.html',
	   '/memory.html',
	   '/others.html',
	   '/show.html',
	   '/page0.html',
	   '/page1.html',
	   '/page2.html',
       '/index.js',
	   '/jquery.js',
	   '/jquery.cookie.js',
	   '/func.js',
	   '/style.css',
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
