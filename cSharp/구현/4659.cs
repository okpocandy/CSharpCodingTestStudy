using System;

namespace C_Sharp_Study.cSharp.구현
{
    internal class PasswordValidator
    {
        static void Main(string[] args)
        {
            string vowels = "aeiou";
            while (true)
            {
                string password = Console.ReadLine();
                if (password == "end") break;

                bool hasVowel = false;
                bool isAcceptable = true;
                int vowelCount = 0, consonantCount = 0;

                for (int i = 0; i < password.Length; i++)
                {
                    // 현재 문자가 모음인지 확인
                    bool isVowel = vowels.Contains(password[i]);
                    if (isVowel)
                    {
                        hasVowel = true;
                        vowelCount++;
                        consonantCount = 0;
                    }
                    else
                    {
                        vowelCount = 0;
                        consonantCount++;
                    }

                    // 모음 또는 자음 3개 연속 확인
                    if (vowelCount == 3 || consonantCount == 3)
                    {
                        isAcceptable = false;
                        break;
                    }

                    // 같은 글자 연속 확인 (예외: ee, oo)
                    if (i > 0 && password[i] == password[i - 1])
                    {
                        if (password[i] != 'e' && password[i] != 'o')
                        {
                            isAcceptable = false;
                            break;
                        }
                    }
                }

                // 모음 포함 여부 확인
                if (!hasVowel)
                    isAcceptable = false;

                // 결과 출력
                if (isAcceptable)
                    Console.WriteLine($"<{password}> is acceptable.");
                else
                    Console.WriteLine($"<{password}> is not acceptable.");
            }
        }
    }
}
