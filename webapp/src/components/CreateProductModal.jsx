import { React, useState } from 'react';
import { Modal, Form, Button } from 'antd';
import { CloseOutlined, SaveOutlined } from '@ant-design/icons';

import ProductForm from './ProductForm';

import { useDataFetch } from '../context/DataFetchContext';
import { useModal } from '../context/ModalContext';

import axios from '../api/axios'

const CreateProductModal = () => {
    const { isCreateModalVisible: isModalVisible, setIsCreateModalVisible: setIsModalVisible } = useModal();
    const { dispatch } = useDataFetch();

    const [isFormDisabled, setIsFormDisabled] = useState(false);

    const [form] = Form.useForm();

    const handleClose = () => {
        setIsModalVisible(false);
        form.resetFields();
    };

    const submitFormAsync = async () => {
        try {
            var validateResults = await form.validateFields();
            setIsFormDisabled(true);

            console.log("Запрос на добавление товара");
            const response = await axios.post("/api/products", validateResults);
            console.log(response);

            await setIsModalVisible(false);
            form.resetFields();

            dispatch({ type: 'TOGGLE_FETCH' });
        }
        catch (error) {
            console.log(error);

            const errors = Object.keys(error.response.data.errors).map((field => ({
                name: field,
                errors: [error.response.data.errors[field]],
            })));
            form.setFields(errors);
        }
        finally {
            setIsFormDisabled(false);
        }
    };

    const FooterButtons = () => {
        return (
            <>
                <Button icon={<SaveOutlined />} type="primary" onClick={submitFormAsync}>Добавить товар</Button>
                <Button icon={<CloseOutlined />} key="back" onClick={handleClose}>Закрыть</Button>
            </>
        );
    };

    return (
        <Modal title="Добавление товара" open={isModalVisible} onCancel={handleClose} footer={FooterButtons}>
            <ProductForm form={form} isFormDisabled={isFormDisabled} />
        </Modal>
    );
};

export default CreateProductModal;