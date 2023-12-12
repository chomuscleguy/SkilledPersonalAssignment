# SkilledPersonalAssignment

현금 = 현금

잔액 = 당좌자산

입금 = 현금에서 빼서 당좌자산으로 더하기

출금 = 당좌자산에서 빼서 현금에서 더하기


잔액을 베이스로 삼고 입금 출금이 연결되게

UI작업 끝

로직 넣는중

GameManager 밑에 depositManager와 WithdrawalManager를 통해 입출금 관리?

캐쉬랑 밸런스는 GameManager가 관리?

싱글톤화해서 depositManager와 WithdrawalManager에 주기

//버튼을 누르면 입출금 실행

버튼 마다 따로 메서드를 만들어야하나?

아니면 한개의 메서드로 가능하려나

버튼에 amount를 달고 

실행함수 따로 설정이 나을듯?

text값을 직접변환? 

입급 시스템 완성

GameManager에서 private로 설정하고 메서드로 depositManager로 가져와서 처리함

inputField 완성

정수를 입력하지 않을 시 디버그로그 나오게 해둠 UI생성해서 팝업창 띄어줄 예정 그리고 exit을 누를 시 input text에 empty가 되었으면 좋겠음

exit보다는 버튼을 눌렀을때 초기화 되는 방향이 좋을 것 같음

음수값이 들어가도 작동이 안되게 설정해야함 

음수값 완

팝업창 완

input Text 초기화 완

통화단위 진행 -> 문제없는데 계속 변환값이 잘못되었다고 나옴

인풋박스에 숫자만 입력 완 <---- 더 공부하고 TIL 써볼 예정


