#include "CoreMinimal.h"
#include "TestHarness.h"

// Other includes must be placed after CoreMinimal.h and TestHarness.h

SCENARIO("Summary of test scenario", "[functional][feature][slow]")
{
	GIVEN("Setup phase")
	{
		// Initialize variables, setup test preconditions etc
		

		WHEN("I perform an action")
		{
			// Change internal state
			
			THEN("Check for expectations")
			{
				CHECK(false);
				REQUIRE(true);
				REQUIRE(false);
			}
		}
	}
}