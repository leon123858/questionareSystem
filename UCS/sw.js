self.addEventListener('install', function(e) {
 e.waitUntil(
   caches.open('video-store').then(function(cache) {
     return cache.addAll([
       '/UCS/',
       '/UCS/confirm.html',
	   '/UCS/memory.html',
	   '/UCS/others.html',
	   '/UCS/show.html',
	   '/UCS/page0.html',
	   '/UCS/page1.html',
	   '/UCS/page2.html',
       '/UCS/index.js',
	   '/UCS/jquery.js',
	   '/UCS/jquery.cookie.js',
	   '/UCS/func.js',
	   '/UCS/style.css',
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
