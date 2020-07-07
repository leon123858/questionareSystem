self.addEventListener('install', function(e) {
 e.waitUntil(
   caches.open('video-store').then(function(cache) {
     return cache.addAll([
       '/questionareSystem/UCS/',
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

addEventListener('fetch', function(event) {
  event.respondWith(
    caches.match(event.request)
      .then(function(response) {
        if (response) {
          return response;     // if valid response is found in cache return it
        } else {
          return fetch(event.request)     //fetch from internet
            .then(function(res) {
              return caches.open(CACHE_DYNAMIC_NAME)
                .then(function(cache) {
                  cache.put(event.request.url, res.clone());    //save the response for future
                  return res;   // return the fetched data
                })
            })
            .catch(function(err) {       // fallback mechanism
              return caches.open(CACHE_CONTAINING_ERROR_MESSAGES)
                .then(function(cache) {
                  return cache.match('/confirm.html');
                });
            });
        }
      })
  );
});          
