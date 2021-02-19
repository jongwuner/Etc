import React from "react";
// nodejs library that concatenates classes
import classNames from "classnames";
// @material-ui/core components
import { makeStyles } from "@material-ui/core/styles";

// @material-ui/icons

// core components
import GridContainer from "components/Grid/GridContainer.js";
import GridItem from "components/Grid/GridItem.js";
import Button from "components/CustomButtons/Button.js";
import Card from "components/Card/Card.js";
import CardBody from "components/Card/CardBody.js";
import CardFooter from "components/Card/CardFooter.js";

import styles from "assets/jss/material-kit-react/views/landingPageSections/teamStyle.js";

import team1 from "assets/img/faces/1.jpg";
import team2 from "assets/img/faces/2.jpg";
import team3 from "assets/img/faces/3.jpg";
import team4 from "assets/img/faces/4.jpg";

const useStyles = makeStyles(styles);

export default function TeamSection() {
  const classes = useStyles();
  const imageClasses = classNames(
    classes.imgRaised,
    classes.imgRoundedCircle,
    classes.imgFluid
  );
  return (
    <div className={classes.section}>
      <h2 className={classes.title}>Here is our team</h2>
      <div>
        <GridContainer>
          <GridItem xs={12} sm={12} md={4}>
            <Card plain>
              <GridItem xs={12} sm={12} md={6} className={classes.itemGrid}>
                <img src={team3} alt="..." className={imageClasses} />
              </GridItem>
              <h4 className={classes.cardTitle}>
                jjongwuner
                <br />
                <small className={classes.smallTitle}>종추</small>
              </h4>
              <CardBody>
                <p className={classes.description}>
                역대 최고의 수색중대장이며, 그의 숨겨진 두번째 직업은 개발자.
                창업을 위한 취업을 목표로 22Hours에 합류했다.
                </p>
                <p className={classes.description}>
                #all-ronuder #Leader #algorithm #javascript
                </p>
              </CardBody>
              <CardFooter className={classes.justifyCenter}>
                <Button
                  justIcon
                  color="transparent"
                  className={classes.margin5}
                >
                  <i className={classes.socials + " fab fa-twitter"} />
                </Button>
                <Button
                  justIcon
                  color="transparent"
                  className={classes.margin5}
                >
                  <i className={classes.socials + " fab fa-instagram"} />
                </Button>
                <Button
                  justIcon
                  color="transparent"
                  className={classes.margin5}
                >
                  <i className={classes.socials + " fab fa-facebook"} />
                </Button>
              </CardFooter>
            </Card>
          </GridItem>
          <GridItem xs={12} sm={12} md={4}>
            <Card plain>
              <GridItem xs={12} sm={12} md={6} className={classes.itemGrid}>
                <img src={team2} alt="..." className={imageClasses} />
              </GridItem>
              <h4 className={classes.cardTitle}>
              Damin
                <br />
                <small className={classes.smallTitle}>김민교</small>
              </h4>
              <CardBody>
                <p className={classes.description}>
                열정과 그의 성장가능성은 타의추종을 불허한다. 리더라면 함께하고 싶은
                팔로워로 배우는 모든 것을 흡수할 줄 아는 이 시대에 맞는 개발자. 좌3우홀에
                목숨을 걸었다고 한다.
                </p>
                <p className={classes.description}>
                #CSharp #Algorithm #Python #좌3우홀
                </p>
              </CardBody>
              <CardFooter className={classes.justifyCenter}>
                <Button
                  justIcon
                  color="transparent"
                  className={classes.margin5}
                >
                  <i className={classes.socials + " fab fa-twitter"} />
                </Button>
                <Button
                  justIcon
                  color="transparent"
                  className={classes.margin5}
                >
                  <i className={classes.socials + " fab fa-linkedin"} />
                </Button>
              </CardFooter>
            </Card>
          </GridItem>
          <GridItem xs={12} sm={12} md={4}>
            <Card plain>
              <GridItem xs={12} sm={12} md={6} className={classes.itemGrid}>
                <img src={team1} alt="..." className={imageClasses} />
              </GridItem>
              <h4 className={classes.cardTitle}>
                Junghawn
                <br />
                <small className={classes.smallTitle}>정롼</small>
              </h4>
              <CardBody>
                <p className={classes.description}>
                개발에 대한 관심과 열망을 따라올 자가 없다. 전형적인 all-rounder의
                면모를 갖췄으며, 특히 UI개발에서는 King이라는 칭호가 항상 따른다.
                </p>
                <p className={classes.description}>
                #all-rounder #UI #황제 #King
                </p>
              </CardBody>
              <CardFooter className={classes.justifyCenter}>
                <Button
                  justIcon
                  color="transparent"
                  className={classes.margin5}
                >
                  <i className={classes.socials + " fab fa-twitter"} />
                </Button>
                <Button
                  justIcon
                  color="transparent"
                  className={classes.margin5}
                >
                  <i className={classes.socials + " fab fa-instagram"} />
                </Button>
                <Button
                  justIcon
                  color="transparent"
                  className={classes.margin5}
                >
                  <i className={classes.socials + " fab fa-facebook"} />
                </Button>
              </CardFooter>
            </Card>
          </GridItem>
          <GridItem xs={12} sm={12} md={4}>
            <Card plain>
              <GridItem xs={12} sm={12} md={6} className={classes.itemGrid}>
                <img src={team4} alt="..." className={imageClasses} />
              </GridItem>
              <h4 className={classes.cardTitle}>
                Jungu
                <br />
                <small className={classes.smallTitle}>홍구의 동생</small>
              </h4>
              <CardBody>
                <p className={classes.description}>
                블록체인의 대가. 개발도 능하지만 공부와 연구에 특화되어있어, 물어보면
                모르는게 딱히 없을 정도로 항상 준비되어있는 개발자. 가끔 술취하면
                감당안되는 프리스타일랩을 한다.
                </p>
                <p className={classes.description}>
                #Block-chain #Go #React.js 
                </p>
              </CardBody>
              <CardFooter className={classes.justifyCenter}>
                <Button
                  justIcon
                  color="transparent"
                  className={classes.margin5}
                >
                  <i className={classes.socials + " fab fa-twitter"} />
                </Button>
                <Button
                  justIcon
                  color="transparent"
                  className={classes.margin5}
                >
                  <i className={classes.socials + " fab fa-linkedin"} />
                </Button>
              </CardFooter>
            </Card>
          </GridItem>
        </GridContainer>
      </div>
    </div>
  );
}
