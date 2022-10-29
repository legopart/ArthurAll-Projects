import React, { useState, useEffect } from "react";
import Backdrop from "@mui/material/Backdrop";
import Box from "@mui/material/Box";
import Modal from "@mui/material/Modal";
import Fade from "@mui/material/Fade";
import Button from "@mui/material/Button";
import Paper from "@mui/material/Paper";
import Typography from "@mui/material/Typography";
import Chart from "../Chart";
import Follow from "../Follow";

import { useSelector } from "react-redux";

const style = {
  position: "absolute",
  top: "50%",
  left: "50%",
  transform: "translate(-50%, -50%)",
  width: "90%",
  bgcolor: "background.paper",
  filter: " opacity(85%)",
  border: "none",
  borderRadius: "5px",
  display: "flex",
  flexDirection: "column",
  justifyContent: "center",
  alignItems: "center",
  //   background: "#90caf9",

  boxShadow: 24,
  p: 4,
};

const HelperModal = ({
  open,
  handleClose,
  statisticAnswers,
  type,
  handleAnswer,
}) => {
  useEffect(() => {
    if (open) {
      // setTimeout(() => handleClose(), 6000);
    }
  }, [open]);
  useEffect(() => {
    console.log(type);
  }, [type]);
  return (
    <Modal
      aria-labelledby="transition-modal-title"
      aria-describedby="transition-modal-description"
      open={open}
      onClose={handleClose}
      closeAfterTransition
      BackdropComponent={Backdrop}
      BackdropProps={{
        timeout: 500,
      }}
    >
      <Fade in={open}>
        <Box sx={style}>
          {type === "statistics" ? (
            <Chart answers={statisticAnswers} />
          ) : type === "follow" ? (
            <Follow handleAnswer={handleAnswer} handleClose={handleClose} />
          ) : null}
        </Box>
      </Fade>
    </Modal>
  );
};

export default HelperModal;
