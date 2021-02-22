# 210221 - node.js nginx proxy_pass 잘 안되네 / openpyxl과 win32com을 통한 데이터 정렬

오늘의 목표는 N사 자동 블로그를 활성화 시키고, 그 부속품이 되는 node.js api 서버를 가동 시킨 뒤, 주식자동화에 대한 시작을 하는 것이다. ~~vlookup 테이블에 대한 설계를 끝마치고 일요일을 끝낸다.~~ 

### 질문

지금 22h.link(ex. 10.20.30.40) 라는 도메인에 서버를 올린 상태고, 현재 nginx를 사용해서 80 -> 443 redirect는 완성한 상태. 근데 node.js를 통해 3000포트에 할당한 app을 사용하려고함. 결과적으로 클라이언트 입장에서는 [https://22h.link로](https://22h.xn--link-ee6q/) request하면 https상태에서 10.20.30.40:3000을 반환받아야 하는데, 그럼 `proxy_pass`를 이용해서 redirect를 443->3000으로만 추가적으로 설정해주면 맞는지?

```jsx
server {
	listen 80, 443;
	server_name 3.15.187.91;
	location / {
		proxy_pass http://localhost:3000;
	}

```

listen이랑 server_name은 필요없는건가? `listen 80, 443;` 은 에러가 조금 났었다. 그래서 이거는 하나만 선언을 해줘야하는게 맞는 것 같다. 그렇게되면 중요한 것이 리다이렉션 경로인데, 80→443→3000인지, 443→80→3000인지 이게 조금 중요하지 않을까 싶다. 

[](https://partnerjun.tistory.com/73)

[NGINX에 대한 정리 #Upstream #Reverse Proxy #Proxy_pass](https://developer88.tistory.com/299)

↑ 되게 잘써놓은 곳.

### Forward Proxy와 Reverse Proxy의 차이

접속제한에 관한 이슈만 Forward Proxy만 해결. Reverse Proxy는 request의 요청을 분산시켜주는 처리

### 심볼릭 링크 & 하드 링크

심볼릭링크 `/etc/nginx/sites-available` → `/etc/nginx/sites-enabled` 

하드링크와 조금 다르겠지만, 바로가기의 느낌이었다. 그래서 항상 원본의 `sites-available` 을 수정해주어야 한다는 점을 잊지 말자. 

### try_files의 의미

### 맘스보드_정렬에 대한 내용은 최종적으로 만들어진 것에 대해, 문자열 오름차순 정렬을 해야겠다.

[파이썬 ](https://alwaysemmyhope.com/ko/python/688844-sorting-with-openpyxl-python-excel-openpyxl.html)
