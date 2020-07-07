self.addEventListener('install', function(e) {
 e.waitUntil(
   caches.open('video-store').then(function(cache) {
     return cache.addAll([
       'https://leon123858.github.io/questionareSystem/UCS/',
       'https://leon123858.github.io/questionareSystem/UCS/confirm.html',
	   'https://leon123858.github.io/questionareSystem/UCS/memory.html',
	   'https://leon123858.github.io/questionareSystem/UCS/others.html',
	   'https://leon123858.github.io/questionareSystem/UCS/show.html',
	   'https://leon123858.github.io/questionareSystem/UCS/page0.html',
	   'https://leon123858.github.io/questionareSystem/UCS/page1.html',
	   'https://leon123858.github.io/questionareSystem/UCS/page2.html',
       'https://leon123858.github.io/questionareSystem/UCS/index.js',
	   'https://leon123858.github.io/questionareSystem/UCS/jquery.js',
	   'https://leon123858.github.io/questionareSystem/UCS/jquery.cookie.js',
	   'https://leon123858.github.io/questionareSystem/UCS/func.js',
	   'https://leon123858.github.io/questionareSystem/UCS/style.css',
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
