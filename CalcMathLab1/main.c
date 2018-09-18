#include <stdio.h>
#include <math.h>

#define ftype double

ftype getXY(ftype PN, ftype P0) {
	return PN / P0;
}

ftype getAlpha(ftype gamma) {
	return (gamma + 1.0) / (gamma - 1.0);
}

ftype getE(ftype C, ftype gamma, ftype U3, ftype U0) {
	return (2.0*powf(C, 2.0)) / (gamma*(gamma - 1)*powf((U3 - U0),2));
}

ftype getC(ftype gamma, ftype P, ftype rho) {
	return sqrtf(gamma*(P / rho));
}

ftype getMax(ftype* array, int size) {
	if (size < 1) {
		return -1;
	} else {
		ftype max = array[0];
		for (int i = 1; i<size; i++) {
			if (array[i] > max) {
				max = array[i];
			}
		}
		return max;
	}
}

int main()
{
	printf("Computational Mathematics Lab #1\nVariant I.1\n(c)2018, Alexander Nekhaev\n\n");
	//Initial values
	ftype gamma0 = 5.0 / 3.0;
	ftype rho0 = 2.219 * powf(10.0, -4.0);
	ftype U0 = -1.587 * powf(10.0, 5.0);
	ftype P0 = 3.7812 * powf(10.0, 6.0);
	
	
	ftype gamma3 = 5.0 / 3;
	ftype rho3 = 2.71 * powf(10.0, -3.0);
	ftype U3 = 10.0;
	ftype P3 = 5.0 * powf(10.0, 5.0);
	
	printf("Initial values:\n\tgamma_0=%f\n\trho_0=%f\n\tU_0=%f\n\tP_0=%f\n\n\tgamma_3=%f\n\trho_3=%f\n\tU_3=%f\n\tP_3=%f\n",gamma0, rho0, U0, P0, gamma3, rho3, U3, P3);
	
	ftype X = getXY(P3, P0);
	ftype alpha0 = getAlpha(gamma0);
	ftype alpha3 = getAlpha(gamma3);
	ftype C0 = getC(gamma0, P0, rho0);
	ftype C3 = getC(gamma3, P3, rho3);
	ftype e3 = getE(C3, gamma3, U3, U0);
	ftype e0 = getE(C0, gamma3, U3, U0);
	
	//Get coefficients
	ftype a0 = powf(alpha0*e3 - alpha3 * e0*X, 2);
	ftype a1 = -2 * (alpha3*e0*X*(e3 + e0 * (2 * alpha3 - X)*X) + e3 * (alpha3 + 2 * e3)*X*powf(alpha0, 2) + alpha0 * (e0*e3*X*(X - 2 * alpha3*(1 + X)) - powf(e3, 2) + e0 * powf(alpha3, 2)*powf(X, 2)));
	ftype a2 = powf(e3, 2)*(1 - 8 * alpha0*X + 6 * powf(alpha0, 2)*powf(X, 2)) + powf(X, 2)*(4 * alpha0*alpha3*e0*(alpha3 - X) + powf(alpha0, 2)*powf(alpha3, 2) + e0 * (-8 * alpha3*e0*X + (-2 + 6 * e0)*powf(alpha3, 2) + e0 * powf(X, 2))) - 2 * e3*X*(e0*X - 2 * alpha3*e0*(1 + X) - 2 * alpha0*e0*X*(1 + X) + (X - 2 * alpha3*X)*powf(alpha0, 2) + alpha0 * alpha3*(2 + e0 * (1 + 4 * X + powf(X, 2))));
	ftype a3 = -2 * X*((-1 + e0)*(alpha0 + 2 * e0)*X*powf(alpha3, 2) + 2 * powf(e3, 2)*(1 - 3 * alpha0*X + powf(alpha0, 2)*powf(X, 2)) + alpha3 * (-((4 * alpha0*e0 + 2 * e0*(-1 + 3 * e0) + powf(alpha0, 2))*powf(X, 2)) + e3 * (1 + e0 - 4 * alpha0*X - 2 * (-2 + alpha0)*e0*X + (1 - 2 * alpha0)*e0*powf(X, 2) + powf(alpha0, 2)*powf(X, 2))) + e3 * X*(-2 * e0*(1 + X) - 2 * X*powf(alpha0, 2) + alpha0 * (2 + e0 * (1 + 4 * X + powf(X, 2)))) + e0 * (alpha0 + 2 * e0)*powf(X, 3));
	ftype a4 = powf(X, 2)*(alpha3*(-4 * (-1 + e0)*(alpha0 + 2 * e0)*X + e3 * (4 - 4 * alpha0*X + e0 * (4 + 4 * X - 2 * alpha0*X))) + powf(alpha3, 2)*powf(-1 + e0, 2) + (4 * alpha0*e0 + 2 * e0*(-1 + 3 * e0) + powf(alpha0, 2))*powf(X, 2) + powf(e3, 2)*(6 - 8 * alpha0*X + powf(alpha0, 2)*powf(X, 2)) - 2 * e3*(1 + e0 - 4 * alpha0*X - 2 * (-2 + alpha0)*e0*X + (1 - 2 * alpha0)*e0*powf(X, 2) + powf(alpha0, 2)*powf(X, 2)));
	ftype a5 = -2 * ((-1 + e0)*(alpha0 + 2 * e0)*X + e3 * (-2 + 2 * alpha0*X + e0 * (-2 + (-2 + alpha0)*X)) + alpha3 * (-1 + e3 + e0 * (2 + e3) - powf(e0, 2)) + (2 - alpha0 * X)*powf(e3, 2))*powf(X, 3);
	ftype a6 = (-2 * e0*(1 + e3) + powf(e0, 2) + powf(-1 + e3, 2))*powf(X, 4);
	
	printf("\nFirst step results(coefficients):\n\ta0=%f\n\ta1=%f\n\ta2=%f\n\ta3=%f\n\ta4=%f\n\ta5=%f\n\ta6=%f\n", a0, a1, a2, a3, a4, a5, a6);
	
	//Root localization
	ftype arrayOneToN[6] = {a1, a2, a3, a4, a5, a6};
	ftype arrayZeroToNMinOne[6] = {a0, a1, a2, a3, a4, a5};
	
	ftype A = getMax(arrayOneToN, 6);
	ftype B = getMax(arrayZeroToNMinOne, 6);
	
	ftype leftEdge = fabs(a6)/(fabs(a6) + B);
	ftype rightEdge = 1 + (A/fabs(a0));
	
	printf ("\nSecond step result(localization):\n\t%f<=|z|<=%f\n", leftEdge, rightEdge);
	return 0;
}
