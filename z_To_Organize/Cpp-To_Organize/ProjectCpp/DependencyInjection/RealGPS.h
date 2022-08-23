#pragma once
#include "IGPS.h"
class RealGPS : public IGPS
{
	// Inherited via IGPS
	virtual float getLatitude() override;
	virtual float getLongitude() override;
};

