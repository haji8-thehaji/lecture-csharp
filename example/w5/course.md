## 복습 : class 상속 
* https://wikidocs.net/227151
## 복습 : 1~100 중 소수 구하기

---
---
# 수업

### 구구단 게임 
*순위 기록 시스템
### 파일 읽고 쓰기 
* https://learn.microsoft.com/ko-kr/troubleshoot/developer/visualstudio/csharp/language-compilers/read-write-text-file

## class 학습
### ConsoleApp3
```
====== === step 1. 클래스와 인스턴스 === ======
서준이(가) 아침을 먹습니다.

====== === step 2. 생성자와 소멸자(종료자) === ======
길고양이 생성자가 호출되었습니다.
고양이의 이름은 하루입니다.
고양이의 이름은 코코입니다.
고양이의 이름은 몰리이며, 나이는 3살 입니다.
코코가 사라집니다.
몰리가 사라집니다.
길고양이가 사라집니다.
하루가 사라집니다.

====== === step 3. 상속 === ======
로봇이 움직입니다.
청소 로봇이 움직입니다.
청소를 시작합니다.
구조 로봇이 움직입니다.
구조를 시작합니다.
로봇이 움직입니다.

====== === step 4. 클래스 값 호출 === ======
고양이의 이름은 코코입니다.
코코가 기지개를 핍니다.

====== === step 5. 접근 제어 === ======
강아지의 이름은 누렁이입니다.
강아지의 이름은 퍼피 입니다.

```
```
interface IAnimal
interface IDog
interface ICat

abstract class Cat : IAnimal, ICat
class Bengal : Cat
class Munchikin : Cat

class Dog : IAnimal, IDog //인터페이스를 사용한 다중 상속
class Poodle : Dog
class Chihuahua : Dog
```
### ConsoleApp4
```
먹다.
짖다.
먹다.
짖다.
no name은(는) 푸들종 입니다.
먹다.
짖다.
no name이(가) 먹다.
뱅갈고양이종 입니다.
no name이(가) 털관리하다.
나비이(가) 먹다.
뱅갈고양이종 입니다.
나비이(가) 털관리하다.
나비이(가) 점프 합니다.
치킨이(가) 먹다.
치킨은(는) 먼치킨종 입니다.
치킨이(가) 털관리하다.
치킨이(가) 털갈이 합니다.
no name이(가) 먹다.
no name은(는) 먼치킨종 입니다.
no name이(가) 털관리하다.
```

### ConsoleApp5
```
이(가) 먹다.
이(가) 짖다.
테스트이(가) 먹다.
테스트이(가) 짖다.
테스트은(는) 푸들종 입니다.
이(가) 먹다.
와리가리이(가) 짖다.
이름을 왈왈이 으로 변경했습니다.
왈왈이이(가) 먹다.
왈왈이이(가) 짖다.
왈왈이은(는) 치와와종 입니다.
```


## 자판기 고도화

## gui 훑어보기
