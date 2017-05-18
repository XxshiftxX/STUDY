using System;
using NSC;

namespace NSC
{
    class Program
    {
        static void Main(string[] args) // 메인 메서드(함수)
        {
            Console.WriteLine("Hello World!"); //도키도키 코딩생활 스타트

            Program p = new Program(); // 생성자

            int intype, outtype; // 몇진수 방식으로 읽고 내보낼지
            string input, output; // 입력받은 / 출력할 값
            int inputInt = 0; //input변수를 10진수로 변환한 값
            while (true)
            {
                Console.Write("입력 시 사용할 진법을 입력해주세요. : ");
                intype = Int32.Parse(Console.ReadLine()); // intype에 값 입력받기 ( Int32.Parse를 통해 Int형으로 변환 )
                if (intype == 2 || intype == 8 || intype == 10 || intype == 16) // intype에 정상적 값 전달 시
                    break; // while문 탈출
                else // 잘못된 값일 시
                    Console.WriteLine("잘못된 값을 입력하셨습니다 (2, 8, 10, 16중 선택)\n\n");
            }

            while (true)
            {
                Console.Write("출력 시 사용할 진법을 입력해주세요. : ");
                outtype = Int32.Parse(Console.ReadLine()); // outtype에 값 입력받기 ( Int32.Parse를 통해 Int형으로 변환 )
                if (outtype == 2 || outtype == 8 || outtype == 10 || outtype == 16) // outtype에 정상적 값 전달 시
                    break; // while문 탈출
                else // 잘못된 값일 시
                    Console.WriteLine("잘못된 값을 입력하셨습니다 (2, 8, 10, 16중 선택)\n\n");
            }

            bool whilet = false;
            do
            {
                whilet = false; // whilet의 기본값을 false로 하고 (while문 탈출 가능)
                Console.Write("변환할 수를 입력해주세요. : ");
                input = Console.ReadLine(); // input에 값 입력받음
                switch(intype)
                {
                    case 2:
                        for(int i = 0; i < input.Length; i++) // 문자열 input의 길이만큼 반복
                        {
                            if (input[i] != '0' && input[i] != '1') // 현재 문자가 0, 1이 아닐 시
                            {
                                Console.WriteLine(intype + "진법에 해당하지 않는 기호가 포함되어 있습니다.\n");
                                whilet = true; // 반복 여부를 true로
                                break;
                            }
                            inputInt += p.rsq(2, input.Length - (i + 1)) * (input[i] - 48); // inputInt에 2의 자리 제곱 * 자릿수 // 공식 이해 안되면 갠톡 ㄱㄱ
                        }
                        break;
                    case 8:
                        for (int i = 0; i < input.Length; i++)  // 문자열 input의 길이만큼 반복
                        {
                            if (input[i] != '0' && input[i] != '1' && input[i] != '2' && input[i] != '2' && input[i] != '3'
                                && input[i] != '4' && input[i] != '5' && input[i] != '6' && input[i] != '7') // 현재 문자가 0 ~ 7이 아닐 시
                            {
                                Console.WriteLine(intype + "진법에 해당하지 않는 기호가 포함되어 있습니다.\n");
                                whilet = true; // 반복 여부를 true로
                                break;
                            }
                            inputInt += p.rsq(8, input.Length - (i + 1)) * (input[i] - 48); // inputInt에 8의 자리 제곱 * 자릿수
                        }
                        break;
                    case 10:
                        for (int i = 0; i < input.Length; i++) // 문자열 input의 길이만큼 반복 
                        {
                            if (input[i] != '0' && input[i] != '1' && input[i] != '2' && input[i] != '2' && input[i] != '3' && input[i] != '4'
                                && input[i] != '5' && input[i] != '6' && input[i] != '7' && input[i] != '8' && input[i] != '9') // 현재 문자가 0 ~ 9가 아닐 시
                            {
                                Console.WriteLine(intype + "진법에 해당하지 않는 기호가 포함되어 있습니다.\n");
                                whilet = true; // 반복 여부를 true로
                                break;
                            }
                        }
                        break;
                    case 16:
                        for (int i = 0; i < input.Length; i++) // 문자열 input의 길이만큼 반복
                        {
                            if (input[i] != '0' && input[i] != '1' && input[i] != '2' && input[i] != '2' && input[i] != '3' && input[i] != '4' && input[i] != '5' && input[i] != '6' && input[i] != '7'
                                && input[i] != '8' && input[i] != '9' && input[i] != 'A' && input[i] != 'B' && input[i] != 'C' && input[i] != 'D' && input[i] != 'E' && input[i] != 'F') // 현재 문자가 0 ~ F가 아닐 시
                            {
                                Console.WriteLine(intype + "진법에 해당하지 않는 기호가 포함되어 있습니다.\n");
                                whilet = true; // 반복 여부를 true로
                                break;
                            }
                            switch (input[i])
                            {
                                case 'A':
                                    inputInt += p.rsq(16, input.Length - (i + 1)) * 10; // inputInt에 16의 자리 제곱 * 10
                                    break;
                                case 'B':
                                    inputInt += p.rsq(16, input.Length - (i + 1)) * 11; // inputInt에 16의 자리 제곱 * 11
                                    break;
                                case 'C':
                                    inputInt += p.rsq(16, input.Length - (i + 1)) * 12; // inputInt에 16의 자리 제곱 * 12
                                    break;
                                case 'D':
                                    inputInt += p.rsq(16, input.Length - (i + 1)) * 13; // inputInt에 16의 자리 제곱 * 13
                                    break;
                                case 'E':
                                    inputInt += p.rsq(16, input.Length - (i + 1)) * 14; // inputInt에 16의 자리 제곱 * 14
                                    break;
                                case 'F':
                                    inputInt += p.rsq(16, input.Length - (i + 1)) * 15; // inputInt에 16의 자리 제곱 * 15
                                    break;
                                default:
                                    inputInt += p.rsq(16, input.Length - (i + 1)) * (input[i] - 48); // inputInt에 16의 자리 제곱 * 자릿수
                                    break;
                            }
                        }
                        break;
                }
				if (inputInt > 65535)
				{
					whilet = false;
					inputInt = 0;
				}
				
            } while (whilet);

			Console.WriteLine ("\n\n");

			switch(outtype)
			{
			case 2:
				Console.WriteLine (p.dexbin (inputInt));
				break;
			case 8:
				Console.WriteLine (p.binoct (p.dexbin (inputInt)));
				break;
			case 10:
				Console.WriteLine (inputInt);
				break;
			case 16:
				Console.WriteLine (p.binhex (p.dexbin (inputInt)));
				break;
			}

            Console.WriteLine("Bye World!"); // 코딩 오와리이~
			Console.ReadLine();
        }

        int rsq(int i, int time) // i의 time제곱을 리떤 하는 함수
        {
            int rtn = 1;
            for (int j = 0; j < time; j++)
                rtn *= i;
            return rtn;
        }

        string dexbin(int dex)
        {
            int dexR = dex; // 수정 가능한 dex
            string rtn = ""; // 반환할 2진수 값

            int i;
            for (i = 0; 0 <= dex - rsq(2, i); i++) // dex에서 2의 몇제곱까지 뺄 수 있는지 확인
                ;

            for (int j = i - 1; j >= 0; j--) // 위에서 구한 i만큼 반복 (i-1한 이유는 뺄 수 없을때 종료했으므로 현재의 i값은 최대치를 넘어간다)
            {
                if (dexR - rsq(2, j) >= 0) // dexR에서 2의 j제곱을 뺄 수 있다면
                {
                    rtn += "1"; // rtn의 끝에 1을 추가하고
                    dexR -= rsq(2, j); // 실제로 dexR에서 2의 j제곱을 빼준다
                }
                else
                    rtn += "0"; //rtn의 끝에 0을 추가한다. (실제로 2의 j제곱을 빼주지는 않는다.)
            }
            return rtn;
        }

        string binoct(string bin)
        {
            string rtn = "", binR = bin; // 반환할 8진수 값과 수정 가능한 bin


            /// 알고가야 할 함수 / 변수
            /// string변수.PadLeft(int a, char b)  :  string변수의 왼쪽을 길이가 a가 될때까지 b로 채운다 (참 PadRight도 있음)
            /// ex) "Hello World!".PadLeft(14, '!') == "!!Hello World!"
            /// string변수.Insert(int a, string b) : 
			///  string변수의 a번째 위치에 b를 삽입한다. (그 자리에 있던거는 뒤로 물러남) (처음 글자는 0으로 취급)
            /// ex) "Hello World!".Insert(3, "|||") == "Hel|||lo World!"
            /// string변수.Split(char a)           :  string변수를 a를 기준으로 잘라서 하나씩 배열에 담는다 (섞여있던 a는 삭제됨)
            /// ex) "Hello World Is Mine".split(" ")[0] == "Hello"
            ///     "Hello World Is Mine".split(" ")[2] == "Is"
            ///     "Hello World Is Mine".split(" ")[3] == "Mine"
            /// 배열.Length  :  배열의 크기

            if (binR.Length % 3 == 1) //binR의 길이를 3으로 나눈 나머지가 1일때  (1 202 101)
            {
                binR = binR.PadLeft(binR.Length + 2, '0'); // binR의 길이 + 2가 될때까지 왼쪽을 0으로 채운다 (001 202 101)
            }
            else if (binR.Length % 3 == 2) //binR의 길이를 3으로 나눈 나머지가 2일때  (41 202 101)
            {
                binR = binR.PadLeft(binR.Length + 1, '0'); // binR의 길이 + 2가 될때까지 왼쪽을 0으로 채운다 (041 202 101)
            }

            for (int i = binR.Length - 3; i > 0; i -= 3) //3칸씩 자르기
                binR = binR.Insert(i, "|");
			
            for (int i = 0; i < binR.Split('|').Length; i++) // |로 자른 배열의 길이 만큼 반복
            {
				switch(binR.Split('|')[i])
				{
				case "000":
					rtn += "0";
					break;
				case "001":
					rtn += "1";
					break;
				case "010":
					rtn += "2";
					break;
				case "011":
					rtn += "3";
					break;
				case "100":
					rtn += "4";
					break;
				case "101":
					rtn += "5";
					break;
				case "110":
					rtn += "6";
					break;
				case "111":
					rtn += "7";
					break;
            	}
			}
			return rtn;
        }

        string binhex(string bin)
        {
            string rtn = "", binR = bin; // 반환할 8진수 값과 수정 가능한 bin

            if (binR.Length % 4 == 1) //binR의 길이를 4로 나눈 나머지가 1일때  (1 1120 2101)
            {
                binR = binR.PadLeft(binR.Length + 3, '0'); // binR의 길이 + 3이 될때까지 왼쪽을 0으로 채운다 (0001 1120 2101)
            }
            else if (binR.Length % 4 == 2) //binR의 길이를 4로 나눈 나머지가 2일때  (12 1274 84A2)
            {
                binR = binR.PadLeft(binR.Length + 2, '0'); // binR의 길이 + 2가 될때까지 왼쪽을 0으로 채운다 (0012 1274 84A2)
            }
            else if (binR.Length % 4 == 3) //binR의 길이를 4로 나눈 나머지가 3일때  (212 1274 84A2)
            {
                binR = binR.PadLeft(binR.Length + 1, '0'); // binR의 길이 + 1이 될때까지 왼쪽을 0으로 채운다 (0212 1274 84A2)
            }
			
			for (int i = binR.Length - 4; i > 0; i -= 4) //3
				binR = binR.Insert(i, "|");
			
			for (int i = 0; i < binR.Split ('|').Length; i++) {
				switch (binR.Split ('|') [i]) 
				{
				case "0000":
					rtn += "0";
					break;
				case "0001":
					rtn += "1";
					break;
				case "0010":
					rtn += "2";
					break;
				case "0011":
					rtn += "3";
					break;
				case "0100":
					rtn += "4";
					break;
				case "0101":
					rtn += "5";
					break;
				case "0110":
					rtn += "6";
					break;
				case "0111":
					rtn += "7";
					break;
				case "1000":
					rtn += "8";
					break;
				case "1001":
					rtn += "9";
					break;
				case "1010":
					rtn += "A";
					break;
				case "1011":
					rtn += "B";
					break;
				case "1100":
					rtn += "C";
					break;
				case "1101":
					rtn += "D";
					break;
				case "1110":
					rtn += "E";
					break;
				case "1111":
					rtn += "F";
					break;
				}
			}
			return rtn;
        }
    }
}