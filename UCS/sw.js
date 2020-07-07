self.addEventListener('install', function(e) {
 e.waitUntil(
   caches.open('video-store').then(function(cache) {
     return cache.addAll([
       '/questionareSystem/UCS/confirm.html',
	   '/questionareSystem/UCS/memory.html',
	   '/questionareSystem/UCS/others.html',
	   '/questionareSystem/UCS/show.html',
	   '/questionareSystem/UCS/page0.html',
	   '/questionareSystem/UCS/page1.html',
	   '/questionareSystem/UCS/page2.html',
       '/questionareSystem/UCS/index.js',
	   '/questionareSystem/UCS/jquery.js',
	   '/questionareSystem/UCS/jquery.cookie.js',
	   '/questionareSystem/UCS/func.js',
	   '/questionareSystem/UCS/style.css'
     ]);
   })
 );
});

self.addEventListener('fetch', function(e) {
  console.log(e.request.url);
  e.respondWith(
    caches.match(e.request, {ignoreSearch: true}).then(function(response) {
      return response || fetch(e.request);
    })
  );
});        
