#include <iostream>
#include <stdio.h>
#include <cstring>
#include <list>

// confidence in my solution: 8/10
// this feels alot clearner and well structured, though I'm not sure about getRoundResult
// it feels like theres probably a nicer way to work out the result 

enum States
{
    rock = 1,
    paper = 2,
    scissors = 3
};

struct Round
{
    int opponent;
    int player;
};

Round  stringToRound(char* round)
{
    // we get the char, convert it to its ascii value (int)
    // then -64 from it, this makes a 1, b 2 and c 3. For xyz
    // values we - 87 to get x 1, y 2, and z 3.
    return {
      (int)round[0] - 64,
      (int)round[2] - 87
    };
}

int getRoundResult(Round round)
{
    // this is fucked but its suprisingly efficient at solving the problem
    if (round.player == round.opponent + 1 || round.player == round.opponent - 2)
    {
        return round.player + 6;
    }
    else if (round.player == round.opponent)
    {
        return round.player + 3;
    }

    return round.player;
}

// for second part of problem
int getRoundResultWithoutAnswer(Round round)
{
    Round tempRound = { round.opponent, (round.opponent + (round.player - 2)) % 3 };
    if (tempRound.player == 0)
        tempRound.player = 3;
    return getRoundResult(tempRound);
}


int main(int argc, char** argv)
{
    std::list<Round> gamePlan;

    char round[5] = "";

    while (true)
    {
        fgets(round, 5, stdin);
        if (round[0] == '\n')
            break;
        gamePlan.push_back(stringToRound(round));
    }

    int totalScore = 0;

    for (Round round : gamePlan)
    {
        //totalScore += getRoundResult(round);
        totalScore += getRoundResultWithoutAnswer(round);
    }

    printf("predicted score is %i", totalScore);

    return 0;
}